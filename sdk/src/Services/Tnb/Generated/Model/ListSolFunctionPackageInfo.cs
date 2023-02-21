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
    /// Information about a function package.
    /// 
    ///  
    /// <para>
    /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
    /// a network function (an ETSI standard telecommunication application) and function package
    /// descriptor that uses the TOSCA standard to describe how the network functions should
    /// run on your network.
    /// </para>
    /// </summary>
    public partial class ListSolFunctionPackageInfo
    {
        private string _arn;
        private string _id;
        private ListSolFunctionPackageMetadata _metadata;
        private OnboardingState _onboardingState;
        private OperationalState _operationalState;
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
        /// ID of the function package.
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
        /// The metadata of the function package.
        /// </para>
        /// </summary>
        public ListSolFunctionPackageMetadata Metadata
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
        /// Onboarding state of the function package.
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
        /// Operational state of the function package.
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
        /// Gets and sets the property UsageState. 
        /// <para>
        /// Usage state of the function package.
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
        /// Identifies the function package and the function package descriptor.
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
        /// Identifies the version of the function package descriptor.
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
        /// The product name for the network function.
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
        /// Provider of the function package and the function package descriptor.
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