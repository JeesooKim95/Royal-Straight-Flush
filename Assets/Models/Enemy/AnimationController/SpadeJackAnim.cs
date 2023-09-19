/*
    Team    : Speaking Potato
    Author  : Haewon Shon
    Date    : 03/17/2021
    Desc    : Heart enemy animation
*/

public class SpadeJackAnim : EnemyAnimBase
{
    protected override void Start()
    {
        base.Start();
    }

    public void OnMeleeAttack()
    {
        base.animator.SetTrigger("OnMeleeAttack");
    }

    public void OnRangeAttack()
    {
        base.animator.SetTrigger("OnRangeAttack");
    }

    public void OnSummon()
    {
        base.animator.SetTrigger("OnSummon");
    }
}
