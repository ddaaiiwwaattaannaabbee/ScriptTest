using UnityEngine;
using System.Collections;

public class Boss {        
        private int hp            = 100; // 体力
        private int power         = 25;  // 攻撃力
		private int mp            = 53;  // mp			
		private int mpConsumption = 5;   // mp消費量

        // 攻撃用の関数
        public void Attack() { 
                Debug.Log( this.power + "のダメージを与えた" );
        }

        // 防御用の関数
        public  void Defence(int damage) { 
                Debug.Log( damage+"のダメージを受けた" );
                // 残りhpを減らす
                this.hp -= damage;
        }

		//魔法攻撃の関数
		public void Magic(){

			if(this.mp<mpConsumption){
				Debug.Log( "MPが足りないため魔法が使えない。" );
			}else{
				this.mp = this.mp - mpConsumption;
				Debug.Log( "魔法攻撃をした。残りMPは" + this.mp + "。" );
			}			
		}

}

public class Test : MonoBehaviour {

        void Start () {

				// 配列の中身を表示
				this.array();

				// Bossクラスの変数を宣言してインスタンスを代入
                Boss lastboss = new Boss ();

                // 攻撃用の関数を呼び出す
                lastboss.Attack();
                // 防御用の関数を呼び出す
                lastboss.Defence(3);

				// 魔法攻撃用の関数を呼び出す
				for(int i=0; i<10; i++){
					lastboss.Magic();
				}

				// MP切れ
				lastboss.Magic();
        }
        
        // Update is called once per frame
        void Update () {
        
        }

	void array() {
		// 配列の初期化
		int[] array = {1,2,4,8,16};

		Debug.Log("配列の中身を表示");
		for(int i=0; i<array.Length ; i++){
			Debug.Log( array[i]);
		}

		Debug.Log("配列の中身を逆順に表示");
		for(int i=array.Length-1; i>-1 ; i--){
			Debug.Log( array[i]);
		}

	}
}