Feature: BasketCase
	Simple calculator for a basket supporting class

Scenario: Empty Baket
	Given an empty basket 
	Then total ammount to pay will be '0.0'

Scenario: One item with price defined
		Given a basket with one item and price for this item is '1.3'
		Then total ammount to pay will be '1.3'
        