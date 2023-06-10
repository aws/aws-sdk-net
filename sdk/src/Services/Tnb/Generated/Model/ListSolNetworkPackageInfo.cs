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
    /// Details of a network package.
    /// 
    ///  
    /// <para>
    /// A network package is a .zip file in CSAR (Cloud Service Archive) format defines the
    /// function packages you want to deploy and the Amazon Web Services infrastructure you
    /// want to deploy them on.
    /// </para>
    /// </summary>
    public partial class ListSolNetworkPackageInfo
    {
        private string _arn;
        private string _id;
        private ListSolNetworkPackageMetadata _metadata;
        private string _nsdDesigner;
        private string _nsdId;
        private string _nsdInvariantId;
        private string _nsdName;
        private NsdOnboardingState _nsdOnboardingState;
        private NsdOperationalState _nsdOperationalState;
        private NsdUsageState _nsdUsageState;
        private string _nsdVersion;
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
        /// ID of the individual network package.
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
        /// <para>
        /// The metadata of the network package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ListSolNetworkPackageMetadata Metadata
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
        /// Gets and sets the property NsdDesigner. 
        /// <para>
        /// Designer of the onboarded network service descriptor in the network package.
        /// </para>
        /// </summary>
        public string NsdDesigner
        {
            get { return this._nsdDesigner; }
            set { this._nsdDesigner = value; }
        }

        // Check to see if NsdDesigner property is set
        internal bool IsSetNsdDesigner()
        {
            return this._nsdDesigner != null;
        }

        /// <summary>
        /// Gets and sets the property NsdId. 
        /// <para>
        /// ID of the network service descriptor on which the network package is based.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NsdInvariantId. 
        /// <para>
        /// Identifies a network service descriptor in a version independent manner.
        /// </para>
        /// </summary>
        public string NsdInvariantId
        {
            get { return this._nsdInvariantId; }
            set { this._nsdInvariantId = value; }
        }

        // Check to see if NsdInvariantId property is set
        internal bool IsSetNsdInvariantId()
        {
            return this._nsdInvariantId != null;
        }

        /// <summary>
        /// Gets and sets the property NsdName. 
        /// <para>
        /// Name of the onboarded network service descriptor in the network package.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NsdVersion. 
        /// <para>
        /// Version of the onboarded network service descriptor in the network package.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property VnfPkgIds. 
        /// <para>
        /// Identifies the function package for the function package descriptor referenced by
        /// the onboarded network package.
        /// </para>
        /// </summary>
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