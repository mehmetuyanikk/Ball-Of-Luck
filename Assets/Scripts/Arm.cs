using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arm : MonoBehaviour
{

    [SerializeField] Rigidbody2D _rb;
    [SerializeField] GameObject _body;
    [SerializeField] Text _scoreText, _score2Text;

    Animator _animator;

    bool _right = true;
    bool _left = false;

    [SerializeField] float _speed = 1;

    int _score = 0;

    void Start()
    {
        _rb.velocity += new Vector2(Random.Range(-25, 25), Random.Range(-25, 25));
    }

    private void Awake()
    {

        _animator = GetComponentInParent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(collision.gameObject);

            _speed -= 0.05f;
            _animator.speed = _speed;

            _body.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);

            _score += 1;
            _scoreText.text = ("Skor: " + _score);
            _score2Text.text = ("Skor: " + _score);

        }

        if (collision.gameObject.CompareTag("enemy"))
        {
            if (_right)
            {
                _animator.Play("New Animation");

                _right = false;
                _left = true;
            }
            else if (_left)
            {
                _animator.Play("New Animation2");
                _left = false;
                _right = true;
            }
        }

        if (collision.gameObject.CompareTag("anger"))
        {
            _rb.velocity += new Vector2(10, 10);
        }

    }

}
