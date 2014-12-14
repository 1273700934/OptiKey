﻿namespace JuliusSweetland.ETTA.UI.ViewModels.Keyboards
{
    public class More : IKeyboard, INavigableKeyboard
    {
        private readonly IKeyboard back;

        public More(IKeyboard back)
        {
            this.back = back;
        }

        public IKeyboard Back
        {
            get { return back; }
        }
    }
}
