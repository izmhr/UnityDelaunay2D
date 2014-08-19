using UnityEngine;
using System.Collections;

public class Delaunay : MonoBehaviour {

	MeshFilter meshFilter;
	Triangulator tr;

	void Start () {
		meshFilter = GetComponentInChildren<MeshFilter>() as MeshFilter;
	}

	void Update () {
		ParticleSystem.Particle[] particles = new ParticleSystem.Particle[particleSystem.particleCount];
		particleSystem.GetParticles(particles);
		Vector2[] particlePoss = new Vector2[particles.Length];
		for( int i = 0; i < particles.Length; i++) {

			particlePoss[i].x = particles[i].position.x;
			particlePoss[i].y = particles[i].position.z;
		}
		if( particles.Length > 3 ){
			tr = new Triangulator();
			meshFilter.mesh = tr.CreateInfluencePolygon(particlePoss);
		}
	}
}
