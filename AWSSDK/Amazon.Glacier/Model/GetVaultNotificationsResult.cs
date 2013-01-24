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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// <para>Contains the Amazon Glacier response to your request.</para>
    /// </summary>
    public class GetVaultNotificationsResult  
    {
        
        private VaultNotificationConfig vaultNotificationConfig;

        /// <summary>
        /// Returns the notification configuration set on the vault.
        ///  
        /// </summary>
        public VaultNotificationConfig VaultNotificationConfig
        {
            get { return this.vaultNotificationConfig; }
            set { this.vaultNotificationConfig = value; }
        }

        /// <summary>
        /// Sets the VaultNotificationConfig property
        /// </summary>
        /// <param name="vaultNotificationConfig">The value to set for the VaultNotificationConfig property </param>
        /// <returns>this instance</returns>
        public GetVaultNotificationsResult WithVaultNotificationConfig(VaultNotificationConfig vaultNotificationConfig)
        {
            this.vaultNotificationConfig = vaultNotificationConfig;
            return this;
        }
            

        // Check to see if VaultNotificationConfig property is set
        internal bool IsSetVaultNotificationConfig()
        {
            return this.vaultNotificationConfig != null;       
        }
    }
}
