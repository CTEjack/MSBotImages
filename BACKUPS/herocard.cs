            {
                // title of the card  
                Title = "Contextere Bot",
                //subtitle of the card  
                // Subtitle = "Hvac Agent Answer",
                // navigate to page , while tab on card  
                Tap = new CardAction(ActionTypes.OpenUrl, "Learn More", value: "http://www.contextere.com"),
                //Detail Text  
                Text = text,     //
                // list of buttons   
                Buttons = new List<CardAction> {  new CardAction(ActionTypes.OpenUrl, "Hvac Agent", value: "https://www.contextere.com"), new CardAction(ActionTypes.OpenUrl, "Work Package", value: taskItemUrl) }
            };