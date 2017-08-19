public class MissVrGeneralScript
{
	protected bool started = false;
	protected float time = 0;

	public void GameEnd() {
		time = 0;
		started = false;
	}

	public void GameStart() {
		time = 0;
		started = true;
	}
}