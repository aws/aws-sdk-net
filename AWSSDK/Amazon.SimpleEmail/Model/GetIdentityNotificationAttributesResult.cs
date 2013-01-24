/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// <para>Describes whether an identity has a bounce topic or complaint topic set, or feedback forwarding enabled.</para>
    /// </summary>
    public class GetIdentityNotificationAttributesResult  
    {
        
        private Dictionary<string,IdentityNotificationAttributes> notificationAttributes = new Dictionary<string,IdentityNotificationAttributes>();

        /// <summary>
        /// A map of Identity to IdentityNotificationAttributes.
        ///  
        /// </summary>
        public Dictionary<string,IdentityNotificationAttributes> NotificationAttributes
        {
            get { return this.notificationAttributes; }
            set { this.notificationAttributes = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the NotificationAttributes dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the NotificationAttributes dictionary.</param>
        /// <returns>this instance</returns>
        public GetIdentityNotificationAttributesResult WithNotificationAttributes(params KeyValuePair<string, IdentityNotificationAttributes>[] pairs)
        {
            foreach (KeyValuePair<string, IdentityNotificationAttributes> pair in pairs)
            {
                this.NotificationAttributes[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if NotificationAttributes property is set
        internal bool IsSetNotificationAttributes()
        {
            return this.notificationAttributes != null;       
        }
    }
}
