/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the pca-connector-scep-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.PcaConnectorScep.Model
{
    /// <summary>
    /// Contains configuration details for use with Microsoft Intune. For information about
    /// using Connector for SCEP for Microsoft Intune, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/scep-connector.htmlconnector-for-scep-intune.html">Using
    /// Connector for SCEP for Microsoft Intune</a>.
    /// 
    ///  
    /// <para>
    /// When you use Connector for SCEP for Microsoft Intune, certain functionalities are
    /// enabled by accessing Microsoft Intune through the Microsoft API. Your use of the Connector
    /// for SCEP and accompanying Amazon Web Services services doesn't remove your need to
    /// have a valid license for your use of the Microsoft Intune service. You should also
    /// review the <a href="https://learn.microsoft.com/en-us/mem/intune/apps/app-protection-policy">Microsoft
    /// Intune® App Protection Policies</a>.
    /// </para>
    /// </summary>
    public partial class IntuneConfiguration
    {
        private string _azureApplicationId;
        private string _domain;

        /// <summary>
        /// Gets and sets the property AzureApplicationId. 
        /// <para>
        /// The directory (tenant) ID from your Microsoft Entra ID app registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=15, Max=100)]
        public string AzureApplicationId
        {
            get { return this._azureApplicationId; }
            set { this._azureApplicationId = value; }
        }

        // Check to see if AzureApplicationId property is set
        internal bool IsSetAzureApplicationId()
        {
            return this._azureApplicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The primary domain from your Microsoft Entra ID app registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

    }
}