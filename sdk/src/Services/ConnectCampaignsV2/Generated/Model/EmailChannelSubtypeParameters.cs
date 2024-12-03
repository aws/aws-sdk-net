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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
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
namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Parameters for the Email Channel Subtype
    /// </summary>
    public partial class EmailChannelSubtypeParameters
    {
        private string _connectSourceEmailAddress;
        private string _destinationEmailAddress;
        private string _templateArn;
        private Dictionary<string, string> _templateParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ConnectSourceEmailAddress.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public string ConnectSourceEmailAddress
        {
            get { return this._connectSourceEmailAddress; }
            set { this._connectSourceEmailAddress = value; }
        }

        // Check to see if ConnectSourceEmailAddress property is set
        internal bool IsSetConnectSourceEmailAddress()
        {
            return this._connectSourceEmailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationEmailAddress.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=255)]
        public string DestinationEmailAddress
        {
            get { return this._destinationEmailAddress; }
            set { this._destinationEmailAddress = value; }
        }

        // Check to see if DestinationEmailAddress property is set
        internal bool IsSetDestinationEmailAddress()
        {
            return this._destinationEmailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateArn.
        /// </summary>
        [AWSProperty(Min=20, Max=500)]
        public string TemplateArn
        {
            get { return this._templateArn; }
            set { this._templateArn = value; }
        }

        // Check to see if TemplateArn property is set
        internal bool IsSetTemplateArn()
        {
            return this._templateArn != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateParameters.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public Dictionary<string, string> TemplateParameters
        {
            get { return this._templateParameters; }
            set { this._templateParameters = value; }
        }

        // Check to see if TemplateParameters property is set
        internal bool IsSetTemplateParameters()
        {
            return this._templateParameters != null && (this._templateParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}