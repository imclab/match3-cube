﻿//using UnityEngine;

//namespace Assets.Scripts.Levels
//{
//	public class LightsBehaviour : LevelBehaviour
//	{
//		public static LightsBehaviour Instance { get; private set; }

//		private Color _defaultColor;
		
//		public Light MainLight;
//		public Light SpotLight1;
//		public Light SpotLight2;
//		public Light SpotLight3;
		

//		public void Awake()
//		{
//			Instance = this;
//			_defaultColor = RenderSettings.ambientLight;
//		}

//		public override void OnRun()
//		{
//			RenderSettings.ambientLight = Color.black;
//			MainLight.gameObject.SetActive(false);

//			SpotLight1.gameObject.SetActive(true);
//			iTween.MoveTo(SpotLight1.gameObject,
//						  iTween.Hash(
//							  iT.MoveTo.path, iTweenPath.GetPath("Path1"),
//							  iT.MoveTo.time, 15,
//							  iT.MoveTo.easetype, iTween.EaseType.linear,
//							  iT.MoveTo.looptype, iTween.LoopType.loop));

//			SpotLight2.gameObject.SetActive(true);
//			iTween.MoveTo(SpotLight2.gameObject,
//						  iTween.Hash(
//							  iT.MoveTo.path, iTweenPath.GetPath("Path2"),
//							  iT.MoveTo.time, 20,
//							  iT.MoveTo.easetype, iTween.EaseType.linear,
//							  iT.MoveTo.looptype, iTween.LoopType.loop));

//			SpotLight3.gameObject.SetActive(true);
//			iTween.MoveTo(SpotLight3.gameObject,
//						  iTween.Hash(
//							  iT.MoveTo.path, iTweenPath.GetPath("Path3"),
//							  iT.MoveTo.time, 25,
//							  iT.MoveTo.easetype, iTween.EaseType.linear,
//							  iT.MoveTo.looptype, iTween.LoopType.loop));
//		}

//		public override void OnStop()
//		{
//			RenderSettings.ambientLight = _defaultColor;
//			MainLight.gameObject.SetActive(true);

//			iTween.Stop(SpotLight1.gameObject);
//			SpotLight1.transform.position = iTweenPath.GetPath("Path1")[0];
//			SpotLight1.gameObject.SetActive(false);

//			iTween.Stop(SpotLight2.gameObject);
//			SpotLight2.transform.position = iTweenPath.GetPath("Path2")[0];
//			SpotLight2.gameObject.SetActive(false);

//			iTween.Stop(SpotLight3.gameObject);
//			SpotLight3.transform.position = iTweenPath.GetPath("Path3")[0];
//			SpotLight3.gameObject.SetActive(false);
//		}

//	}
//}
