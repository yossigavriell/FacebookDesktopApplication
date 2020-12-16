using System;

namespace FacebookAppForm
{
    class FactoryFacebookForm
    {
        public static FacebookGeneralForm CreateInstance(Type i_Instance)
        {
            FacebookGeneralForm facebookGeneralForm = null;

            if (i_Instance.IsSubclassOf(typeof(FacebookGeneralForm)))
            {
                facebookGeneralForm = Activator.CreateInstance(i_Instance) as FacebookGeneralForm;
            }

            return facebookGeneralForm;
        }
    }
}
