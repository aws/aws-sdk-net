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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Tnb.Model
{
    /// <summary>
    /// This is the response object from the GetSolFunctionPackage operation.
    /// </summary>
    public partial class GetSolFunctionPackageResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _id;
        private GetSolFunctionPackageMetadata _metadata;
        private OnboardingState _onboardingState;
        private OperationalState _operationalState;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private UsageState _usageState;
        private string _vnfdId;
        private string _vnfdVersion;
        private string _vnfProductName;
        private string _vnfProvider;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Function package ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Function package ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata.
        /// </summary>
        public GetSolFunctionPackageMetadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property OnboardingState. 
        /// <para>
        /// Function package onboarding state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OnboardingState OnboardingState
        {
            get { return this._onboardingState; }
            set { this._onboardingState = value; }
        }

        // Check to see if OnboardingState property is set
        internal bool IsSetOnboardingState()
        {
            return this._onboardingState != null;
        }

        /// <summary>
        /// Gets and sets the property OperationalState. 
        /// <para>
        /// Function package operational state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OperationalState OperationalState
        {
            get { return this._operationalState; }
            set { this._operationalState = value; }
        }

        // Check to see if OperationalState property is set
        internal bool IsSetOperationalState()
        {
            return this._operationalState != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A tag is a label that you assign to an Amazon Web Services resource. Each tag consists
        /// of a key and an optional value. You can use tags to search and filter your resources
        /// or track your Amazon Web Services costs.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UsageState. 
        /// <para>
        /// Function package usage state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UsageState UsageState
        {
            get { return this._usageState; }
            set { this._usageState = value; }
        }

        // Check to see if UsageState property is set
        internal bool IsSetUsageState()
        {
            return this._usageState != null;
        }

        /// <summary>
        /// Gets and sets the property VnfdId. 
        /// <para>
        /// Function package descriptor ID.
        /// </para>
        /// </summary>
        public string VnfdId
        {
            get { return this._vnfdId; }
            set { this._vnfdId = value; }
        }

        // Check to see if VnfdId property is set
        internal bool IsSetVnfdId()
        {
            return this._vnfdId != null;
        }

        /// <summary>
        /// Gets and sets the property VnfdVersion. 
        /// <para>
        /// Function package descriptor version.
        /// </para>
        /// </summary>
        public string VnfdVersion
        {
            get { return this._vnfdVersion; }
            set { this._vnfdVersion = value; }
        }

        // Check to see if VnfdVersion property is set
        internal bool IsSetVnfdVersion()
        {
            return this._vnfdVersion != null;
        }

        /// <summary>
        /// Gets and sets the property VnfProductName. 
        /// <para>
        /// Network function product name.
        /// </para>
        /// </summary>
        public string VnfProductName
        {
            get { return this._vnfProductName; }
            set { this._vnfProductName = value; }
        }

        // Check to see if VnfProductName property is set
        internal bool IsSetVnfProductName()
        {
            return this._vnfProductName != null;
        }

        /// <summary>
        /// Gets and sets the property VnfProvider. 
        /// <para>
        /// Network function provider.
        /// </para>
        /// </summary>
        public string VnfProvider
        {
            get { return this._vnfProvider; }
            set { this._vnfProvider = value; }
        }

        // Check to see if VnfProvider property is set
        internal bool IsSetVnfProvider()
        {
            return this._vnfProvider != null;
        }

    }
}