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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Response structure containing detailed support level for an account
    /// </summary>
    public partial class DescribeSupportLevelResponse : AmazonWebServiceResponse
    {
        private bool? _activeSubscription;
        private SupportLevel _mosaicSupportLevel;
        private SupportLevel _supportLevel;

        /// <summary>
        /// Gets and sets the property ActiveSubscription. 
        /// <para>
        /// Whether or not the account's subscription is active
        /// </para>
        /// </summary>
        public bool? ActiveSubscription
        {
            get { return this._activeSubscription; }
            set { this._activeSubscription = value; }
        }

        // Check to see if ActiveSubscription property is set
        internal bool IsSetActiveSubscription()
        {
            return this._activeSubscription.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MosaicSupportLevel. 
        /// <para>
        /// The account's Mosaic equivalent support level
        /// </para>
        /// </summary>
        public SupportLevel MosaicSupportLevel
        {
            get { return this._mosaicSupportLevel; }
            set { this._mosaicSupportLevel = value; }
        }

        // Check to see if MosaicSupportLevel property is set
        internal bool IsSetMosaicSupportLevel()
        {
            return this._mosaicSupportLevel != null;
        }

        /// <summary>
        /// Gets and sets the property SupportLevel. 
        /// <para>
        /// The account's support level
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SupportLevel SupportLevel
        {
            get { return this._supportLevel; }
            set { this._supportLevel = value; }
        }

        // Check to see if SupportLevel property is set
        internal bool IsSetSupportLevel()
        {
            return this._supportLevel != null;
        }

    }
}