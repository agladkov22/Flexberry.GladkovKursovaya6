﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Gladkov_Kursovaya
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Склады.
    /// </summary>
    // *** Start programmer edit section *** (Склады CustomAttributes)

    // *** End programmer edit section *** (Склады CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СкладыE", new string[] {
            "ID as \'ID\'",
            "Наименование as \'Наименование\'"})]
    [View("СкладыL", new string[] {
            "ID as \'ID\'",
            "Наименование as \'Наименование\'"})]
    public class Склады : ICSSoft.STORMNET.DataObject
    {
        
        private int fID;
        
        private string fНаименование;
        
        // *** Start programmer edit section *** (Склады CustomMembers)

        // *** End programmer edit section *** (Склады CustomMembers)

        
        /// <summary>
        /// ID.
        /// </summary>
        // *** Start programmer edit section *** (Склады.ID CustomAttributes)

        // *** End programmer edit section *** (Склады.ID CustomAttributes)
        public virtual int ID
        {
            get
            {
                // *** Start programmer edit section *** (Склады.ID Get start)

                // *** End programmer edit section *** (Склады.ID Get start)
                int result = this.fID;
                // *** Start programmer edit section *** (Склады.ID Get end)

                // *** End programmer edit section *** (Склады.ID Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Склады.ID Set start)

                // *** End programmer edit section *** (Склады.ID Set start)
                this.fID = value;
                // *** Start programmer edit section *** (Склады.ID Set end)

                // *** End programmer edit section *** (Склады.ID Set end)
            }
        }
        
        /// <summary>
        /// Наименование.
        /// </summary>
        // *** Start programmer edit section *** (Склады.Наименование CustomAttributes)

        // *** End programmer edit section *** (Склады.Наименование CustomAttributes)
        [StrLen(255)]
        public virtual string Наименование
        {
            get
            {
                // *** Start programmer edit section *** (Склады.Наименование Get start)

                // *** End programmer edit section *** (Склады.Наименование Get start)
                string result = this.fНаименование;
                // *** Start programmer edit section *** (Склады.Наименование Get end)

                // *** End programmer edit section *** (Склады.Наименование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Склады.Наименование Set start)

                // *** End programmer edit section *** (Склады.Наименование Set start)
                this.fНаименование = value;
                // *** Start programmer edit section *** (Склады.Наименование Set end)

                // *** End programmer edit section *** (Склады.Наименование Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СкладыE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СкладыE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СкладыE", typeof(IIS.Gladkov_Kursovaya.Склады));
                }
            }
            
            /// <summary>
            /// "СкладыL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СкладыL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СкладыL", typeof(IIS.Gladkov_Kursovaya.Склады));
                }
            }
        }
    }
}
