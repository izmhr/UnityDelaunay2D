using UnityEngine;
using System.Collections;

public class DelaunayFix : MonoBehaviour {

	public int num;
	public float radius;
	public float particlesize;

//	PARTICLE SYSTEM
	private ParticleSystem.Particle[] particles;
	private Vector2[] particlePoss;

	MeshFilter meshFilter;

	void Start () {
		particles = new ParticleSystem.Particle[num];
		particlePoss = new Vector2[num];

		meshFilter = GetComponentInChildren<MeshFilter>() as MeshFilter;

		for( int i = 0; i < num; i++) {
			particles[i].position = radius * Random.insideUnitCircle;
			particlePoss[i] = particles[i].position;
			particles[i].color = Color.white;
			particles[i].size = particlesize;
		}

		Triangulator tr = new Triangulator();
		meshFilter.mesh = tr.CreateInfluencePolygon(particlePoss);
	}

	void Update () {
		particleSystem.SetParticles(particles, particles.Length);
	}
}
