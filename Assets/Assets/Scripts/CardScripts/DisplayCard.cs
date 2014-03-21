﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SpriteRenderer))]
public class DisplayCard : MonoBehaviour {
  public CardSet sprites;
  private int _cardValue;
  public int cardValue { get { return _cardValue;} }
  private SpriteRenderer spriteRenderer; 
  private Sprite sprite { 
    set {
      spriteRenderer.sprite = value;
    }
  }

	void Start () {
    spriteRenderer = (SpriteRenderer) gameObject.renderer;
    //DrawEmpty();
	}

	void Update () {
	}

  public void Init() {
    spriteRenderer = (SpriteRenderer) gameObject.renderer;
  }

  public void DrawCard(int val) {
    _cardValue = val;
    sprite = sprites.cardSprites[val];
  }

  public void DrawBack() {
    sprite = sprites.backSprite;
  }

  public void DrawEmpty() {
    sprite = sprites.emptySprite;
  }

  public void DrawOutline() {
    sprite = sprites.outlineSprite;
  }
}