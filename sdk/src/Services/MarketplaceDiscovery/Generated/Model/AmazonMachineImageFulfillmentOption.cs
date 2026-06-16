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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
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
namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// Describes an Amazon Machine Image (AMI) fulfillment option, including version details,
    /// supported operating systems, and recommended instance types.
    /// </summary>
    public partial class AmazonMachineImageFulfillmentOption
    {
        private string _fulfillmentOptionDisplayName;
        private string _fulfillmentOptionId;
        private string _fulfillmentOptionName;
        private FulfillmentOptionType _fulfillmentOptionType;
        private string _fulfillmentOptionVersion;
        private List<AmazonMachineImageOperatingSystem> _operatingSystems = AWSConfigs.InitializeCollections ? new List<AmazonMachineImageOperatingSystem>() : null;
        private AmazonMachineImageRecommendation _recommendation;
        private string _releaseNotes;
        private string _usageInstructions;

        /// <summary>
        /// Gets and sets the property FulfillmentOptionDisplayName. 
        /// <para>
        /// A human-readable name for the fulfillment option type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FulfillmentOptionDisplayName
        {
            get { return this._fulfillmentOptionDisplayName; }
            set { this._fulfillmentOptionDisplayName = value; }
        }

        // Check to see if FulfillmentOptionDisplayName property is set
        internal bool IsSetFulfillmentOptionDisplayName()
        {
            return this._fulfillmentOptionDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property FulfillmentOptionId. 
        /// <para>
        /// The unique identifier of the fulfillment option.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FulfillmentOptionId
        {
            get { return this._fulfillmentOptionId; }
            set { this._fulfillmentOptionId = value; }
        }

        // Check to see if FulfillmentOptionId property is set
        internal bool IsSetFulfillmentOptionId()
        {
            return this._fulfillmentOptionId != null;
        }

        /// <summary>
        /// Gets and sets the property FulfillmentOptionName. 
        /// <para>
        /// The display name of the fulfillment option version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FulfillmentOptionName
        {
            get { return this._fulfillmentOptionName; }
            set { this._fulfillmentOptionName = value; }
        }

        // Check to see if FulfillmentOptionName property is set
        internal bool IsSetFulfillmentOptionName()
        {
            return this._fulfillmentOptionName != null;
        }

        /// <summary>
        /// Gets and sets the property FulfillmentOptionType. 
        /// <para>
        /// The category of the fulfillment option.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FulfillmentOptionType FulfillmentOptionType
        {
            get { return this._fulfillmentOptionType; }
            set { this._fulfillmentOptionType = value; }
        }

        // Check to see if FulfillmentOptionType property is set
        internal bool IsSetFulfillmentOptionType()
        {
            return this._fulfillmentOptionType != null;
        }

        /// <summary>
        /// Gets and sets the property FulfillmentOptionVersion. 
        /// <para>
        /// The version identifier of the fulfillment option.
        /// </para>
        /// </summary>
        public string FulfillmentOptionVersion
        {
            get { return this._fulfillmentOptionVersion; }
            set { this._fulfillmentOptionVersion = value; }
        }

        // Check to see if FulfillmentOptionVersion property is set
        internal bool IsSetFulfillmentOptionVersion()
        {
            return this._fulfillmentOptionVersion != null;
        }

        /// <summary>
        /// Gets and sets the property OperatingSystems. 
        /// <para>
        /// The operating systems supported by this AMI.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AmazonMachineImageOperatingSystem> OperatingSystems
        {
            get { return this._operatingSystems; }
            set { this._operatingSystems = value; }
        }

        // Check to see if OperatingSystems property is set
        internal bool IsSetOperatingSystems()
        {
            return this._operatingSystems != null && (this._operatingSystems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Recommendation. 
        /// <para>
        /// Recommended instance types for running this AMI.
        /// </para>
        /// </summary>
        public AmazonMachineImageRecommendation Recommendation
        {
            get { return this._recommendation; }
            set { this._recommendation = value; }
        }

        // Check to see if Recommendation property is set
        internal bool IsSetRecommendation()
        {
            return this._recommendation != null;
        }

        /// <summary>
        /// Gets and sets the property ReleaseNotes. 
        /// <para>
        /// Release notes describing changes in this version of the fulfillment option.
        /// </para>
        /// </summary>
        public string ReleaseNotes
        {
            get { return this._releaseNotes; }
            set { this._releaseNotes = value; }
        }

        // Check to see if ReleaseNotes property is set
        internal bool IsSetReleaseNotes()
        {
            return this._releaseNotes != null;
        }

        /// <summary>
        /// Gets and sets the property UsageInstructions. 
        /// <para>
        /// Instructions on how to deploy and use this fulfillment option.
        /// </para>
        /// </summary>
        public string UsageInstructions
        {
            get { return this._usageInstructions; }
            set { this._usageInstructions = value; }
        }

        // Check to see if UsageInstructions property is set
        internal bool IsSetUsageInstructions()
        {
            return this._usageInstructions != null;
        }

    }
}