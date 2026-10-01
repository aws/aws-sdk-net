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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
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
namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// Contains metadata for a procurement portal, including the portal identifier, name,
    /// and default feature configurations.
    /// </summary>
    public partial class ProcurementPortal
    {
        private FeatureConfigurations _defaultFeatureConfigurations;
        private string _portalDisplayName;
        private string _portalIdentifier;
        private ProcurementPortalName _portalName;

        /// <summary>
        /// Gets and sets the property DefaultFeatureConfigurations. 
        /// <para>
        /// The default feature configurations for the procurement portal.
        /// </para>
        /// </summary>
        public FeatureConfigurations DefaultFeatureConfigurations
        {
            get { return this._defaultFeatureConfigurations; }
            set { this._defaultFeatureConfigurations = value; }
        }

        // Check to see if DefaultFeatureConfigurations property is set
        internal bool IsSetDefaultFeatureConfigurations()
        {
            return this._defaultFeatureConfigurations != null;
        }

        /// <summary>
        /// Gets and sets the property PortalDisplayName. 
        /// <para>
        /// The display name of the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string PortalDisplayName
        {
            get { return this._portalDisplayName; }
            set { this._portalDisplayName = value; }
        }

        // Check to see if PortalDisplayName property is set
        internal bool IsSetPortalDisplayName()
        {
            return this._portalDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property PortalIdentifier. 
        /// <para>
        /// The unique identifier of the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string PortalIdentifier
        {
            get { return this._portalIdentifier; }
            set { this._portalIdentifier = value; }
        }

        // Check to see if PortalIdentifier property is set
        internal bool IsSetPortalIdentifier()
        {
            return this._portalIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property PortalName. 
        /// <para>
        /// The name of the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProcurementPortalName PortalName
        {
            get { return this._portalName; }
            set { this._portalName = value; }
        }

        // Check to see if PortalName property is set
        internal bool IsSetPortalName()
        {
            return this._portalName != null;
        }

    }
}