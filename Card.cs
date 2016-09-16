public abstract class Card {
	private int cardId = -1;

	public string Name { get; set; }
	public string Description { get; set; }

	public Card(int cardId) {
		this.cardId = cardId;
	}
}