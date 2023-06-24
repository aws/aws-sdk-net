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
    /// This is the response object from the CreateSolNetworkPackage operation.
    /// </summary>
    public partial class CreateSolNetworkPackageResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _id;
        private NsdOnboardingState _nsdOnboardingState;
        private NsdOperationalState _nsdOperationalState;
        private NsdUsageState _nsdUsageState;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

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
        /// ID of the network package.
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
        /// Gets and sets the property NsdOnboardingState. 
        /// <para>
        /// Onboarding state of the network service descriptor in the network package.
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
        /// Operational state of the network service descriptor in the network package.
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
        /// Usage state of the network service descriptor in the network package.
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

    }
}