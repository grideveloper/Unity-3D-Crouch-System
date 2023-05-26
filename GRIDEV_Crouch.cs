//--------------------------------------
//created by grigamedevelopment.com.tr
//BURAK KARADAG / karadagburak1881@gmail.com
//-----------------------------------------

//ADD INSIDE YOUR CLASS
IEnumerator StartCrouchingSystem()
{
    _isCrouching = true;
    _playerAnimator.SetBool("isCrouching", true);
    yield return new WaitForSeconds(0.3f);
    _playerCharacterController.height = 1.5f;
    _playerCharacterController.center = new Vector3(_playerCharacterController.center.x, 0.75f, 0.25f);
}
IEnumerator StopCrouchingSystem()
{
    _playerAnimator.SetBool("isCrouching", false);
    yield return new WaitForSeconds(0.2f);
    _isCrouching = false;
    _playerCharacterController.height = 2f;
    _playerCharacterController.center = new Vector3(_playerCharacterController.center.x, 1f, 0f);
}

//ADD INSIDE YOUR METHOD
if (Input.GetKeyDown(KeyCode.LeftControl) && !_isCrouching)
{
    StartCoroutine(StartCrouchingSystem());
}
else if (Input.GetKeyDown(KeyCode.LeftControl) && _isCrouching)
{
    StartCoroutine(StopCrouchingSystem());
}

//---THEN CONNECT WITH YOUR MOVEMENT SYSTEM---\\