#nullable enable

using StardewModdingAPI.Utilities;

using Leclair.Stardew.BetterCrafting.Models;

using Leclair.Stardew.Common.Enums;
using Leclair.Stardew.Common.Inventory;
using Leclair.Stardew.Common.Types;

namespace Leclair.Stardew.BetterCrafting;

public enum GiftStyle {
	Heads,
	Names
};

public enum GiftMode {
	Never,
	Shift,
	Always
};

public enum MenuPriority {
	Low,
	Normal,
	High
};

public enum MaxQuality {
	Disabled,
	None,
	Silver,
	Gold,
	Iridium
};

public enum ButtonAction {
	None,
	Craft,
	BulkCraft,
	Favorite
};

public enum TTWhen {
	Never,
	ForController,
	Always
};

public class ModConfig {

	public string Theme { get; set; } = "automatic";

	public bool ReplaceCooking { get; set; } = true;
	public bool ReplaceCrafting { get; set; } = true;

	public bool UseCategories { get; set; } = true;

	public bool ShowSettingsButton { get; set; } = true;

	public MenuPriority MenuPriority { get; set; } = MenuPriority.Normal;

	public GiftMode ShowTastes { get; set; } = GiftMode.Shift;
	public bool ShowAllTastes { get; set; } = false;
	public GiftStyle TasteStyle { get; set; } = GiftStyle.Heads;

	// Quality
	public MaxQuality MaxQuality { get; set; } = MaxQuality.Iridium;
	public bool LowQualityFirst { get; set; } = true;

	// Bindings
	public TTWhen ShowKeybindTooltip { get; set; } = TTWhen.ForController;

	public KeybindList SuppressBC { get; set; } = KeybindList.Parse("LeftShift");
	public KeybindList ModiferKey { get; set; } = KeybindList.Parse("LeftShift, RightTrigger");
	public KeybindList FavoriteKey { get; set; } = KeybindList.Parse("F, ControllerBack");
	public KeybindList BulkCraftKey { get; set; } = KeybindList.Parse("None");
	public KeybindList SearchKey { get; set; } = KeybindList.Parse("F3");

	// Actions
	public ButtonAction LeftClick { get; set; } = ButtonAction.Craft;
	public ButtonAction RightClick { get; set; } = ButtonAction.BulkCraft;


	// Standard Crafting
	public bool UseUniformGrid { get; set; } = false;
	public bool SortBigLast { get; set; } = false;
	public bool CraftingAlphabetic { get; set; } = false;

	// Cooking
	public SeasoningMode UseSeasoning { get; set; } = SeasoningMode.Enabled;
	public bool HideUnknown { get; set; } = false;
	public bool CookingAlphabetic { get; set; } = false;


	// Better Workbench
	public bool UseDiscovery { get; set; } = true;
	public int MaxInventories { get; set; } = 32;
	public int MaxDistance { get; set; } = 20;
	public int MaxCheckedTiles { get; set; } = 500;
	public int MaxWorkbenchGap { get; set; } = 0;

	public bool UseDiagonalConnections { get; set; } = true;

	public CaseInsensitiveHashSet ValidConnectors { get; set; } = new();

	// Better Cookout Kit
	public bool EnableCookoutWorkbench { get; set; } = true;
	public bool EnableCookoutLongevity { get; set; } = false;
	public bool EnableCookoutExpensive { get; set; } = false;

	// Transfer Behavior

	public bool UseTransfer { get; set; } = true;
	public Behaviors AddToBehaviors { get; set; } = new Behaviors();
	public Behaviors FillFromBehaviors { get; set; } = new Behaviors();
}

public class Behaviors {

	public TransferBehavior UseTool { get; set; } = new TransferBehavior(TransferMode.All, 1);
	public TransferBehavior UseToolModified { get; set; } = new TransferBehavior(TransferMode.AllButQuantity, 1);

	public TransferBehavior Action { get; set; } = new TransferBehavior(TransferMode.Quantity, 1);
	public TransferBehavior ActionModified { get; set; } = new TransferBehavior(TransferMode.Half, 1);

}
