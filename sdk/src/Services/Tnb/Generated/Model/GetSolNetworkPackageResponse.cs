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
    /// This is the response object from the GetSolNetworkPackage operation.
    /// </summary>
    public partial class GetSolNetworkPackageResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _id;
        private GetSolNetworkPackageMetadata _metadata;
        private string _nsdId;
        private string _nsdName;
        private NsdOnboardingState _nsdOnboardingState;
        private NsdOperationalState _nsdOperationalState;
        private NsdUsageState _nsdUsageState;
        private string _nsdVersion;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private List<string> _vnfPkgIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Network package ARN.
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
        /// Network package ID.
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
        [AWSProperty(Required=true)]
        public GetSolNetworkPackageMetadata Metadata
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
        /// Gets and sets the property NsdId. 
        /// <para>
        /// Network service descriptor ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsdId
        {
            get { return this._nsdId; }
            set { this._nsdId = value; }
        }

        // Check to see if NsdId property is set
        internal bool IsSetNsdId()
        {
            return this._nsdId != null;
        }

        /// <summary>
        /// Gets and sets the property NsdName. 
        /// <para>
        /// Network service descriptor name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsdName
        {
            get { return this._nsdName; }
            set { this._nsdName = value; }
        }

        // Check to see if NsdName property is set
        internal bool IsSetNsdName()
        {
            return this._nsdName != null;
        }

        /// <summary>
        /// Gets and sets the property NsdOnboardingState. 
        /// <para>
        /// Network service descriptor onboarding state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NsdOnboardingState NsdOnboardingState
        {
            get { return this._nsdOnboardingState; }
            set { this._nsdOnboardingState = value; }
        }

        // Check to see if NsdOnboardingState property is set
        internal bool IsSetNsdOnboardingState()
        {
            return this._nsdOnboardingState != null;
        }

        /// <summary>
        /// Gets and sets the property NsdOperationalState. 
        /// <para>
        /// Network service descriptor operational state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NsdOperationalState NsdOperationalState
        {
            get { return this._nsdOperationalState; }
            set { this._nsdOperationalState = value; }
        }

        // Check to see if NsdOperationalState property is set
        internal bool IsSetNsdOperationalState()
        {
            return this._nsdOperationalState != null;
        }

        /// <summary>
        /// Gets and sets the property NsdUsageState. 
        /// <para>
        /// Network service descriptor usage state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NsdUsageState NsdUsageState
        {
            get { return this._nsdUsageState; }
            set { this._nsdUsageState = value; }
        }

        // Check to see if NsdUsageState property is set
        internal bool IsSetNsdUsageState()
        {
            return this._nsdUsageState != null;
        }

        /// <summary>
        /// Gets and sets the property NsdVersion. 
        /// <para>
        /// Network service descriptor version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsdVersion
        {
            get { return this._nsdVersion; }
            set { this._nsdVersion = value; }
        }

        // Check to see if NsdVersion property is set
        internal bool IsSetNsdVersion()
        {
            return this._nsdVersion != null;
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
        /// Gets and sets the property VnfPkgIds. 
        /// <para>
        /// Identifies the function package for the function package descriptor referenced by
        /// the onboarded network package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> VnfPkgIds
        {
            get { return this._vnfPkgIds; }
            set { this._vnfPkgIds = value; }
        }

        // Check to see if VnfPkgIds property is set
        internal bool IsSetVnfPkgIds()
        {
            return this._vnfPkgIds != null && this._vnfPkgIds.Count > 0; 
        }

    }
}