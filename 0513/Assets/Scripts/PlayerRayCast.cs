using UnityEngine;

public class PlayerRayCast : MonoBehaviour
{
    [SerializeField] private float rayDistance = 5f;

    void Update()
    {
        // Ray (시작위치, 방향)
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        // Physics.Raycast: 실제로 물리 세계에 레이를 쏘는 함수입니다. 성공하면 true, 아무것도 안 맞으면 false를 반환
        // out hit: 핵심 키워드. 함수 밖에서 선언한 hit 상자를 함수 내부로 전달하여, 충돌 정보가 생기면 그 상자 안에 내용을 채워서 돌려달라는 뜻입니다.
        // rayDistance: 레이가 최대 얼마까지 닿을 수 있는지를 설정하는 매개변수입니다. 이 값보다 멀리 있는 물체는 레이에 맞아도 감지되지 않습니다.
        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            Debug.Log($"Hit object: {hit.collider.gameObject.name}");
        }

        // Debug.DrawRay: 레이를 시각적으로 보여주는 함수입니다. 게임 뷰에서는 보이지 않고 씬 뷰에서만 보입니다.
        Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.red);
    }
}
