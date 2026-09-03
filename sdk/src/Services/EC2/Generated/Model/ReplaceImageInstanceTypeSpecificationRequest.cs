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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ReplaceImageInstanceTypeSpecification operation.
    /// Replaces or removes the instance type specification for an AMI. The instance type
    /// specification defines which instance types are compatible with the AMI.
    /// 
    ///  
    /// <para>
    /// When you launch an instance using <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RunInstances.html">RunInstances</a>,
    /// Amazon EC2 validates the requested instance type against the AMI's instance type specification.
    /// If the instance type is not compatible, the request fails with an <c>InvalidParameterCombination</c>
    /// error.
    /// </para>
    ///  
    /// <para>
    /// You can specify supported instance types, unsupported instance types, or both. The
    /// evaluation logic is as follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// No specification set – all instance types are allowed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Only <c>UnsupportedInstanceTypes</c> set – All instance types are allowed except those
    /// that match the unsupported list.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>SupportedInstanceTypes</c> set – The instance type must match the supported list
    /// and must not match the unsupported list.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Instance type entries support wildcard patterns using <c>*</c> (for example, <c>t3.*</c>
    /// matches all t3 sizes).
    /// </para>
    ///  
    /// <para>
    /// To remove an existing instance type specification, omit the <c>InstanceTypeSpecification</c>
    /// parameter or set it to <c>null</c>.
    /// </para>
    ///  
    /// <para>
    /// To set the instance type specification, you must be the AMI owner. You cannot set
    /// an instance type specification on an AMI that is listed in Amazon Web Services Marketplace,
    /// and you cannot list an AMI in Amazon Web Services Marketplace if it has an instance
    /// type specification set.
    /// </para>
    /// </summary>
    public partial class ReplaceImageInstanceTypeSpecificationRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _imageId;
        private InstanceTypeSpecificationRequest _instanceTypeSpecification;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceTypeSpecification. 
        /// <para>
        /// The instance type specification to set on the AMI. Omit this parameter to remove the
        /// existing instance type specification.
        /// </para>
        /// </summary>
        public InstanceTypeSpecificationRequest InstanceTypeSpecification
        {
            get { return this._instanceTypeSpecification; }
            set { this._instanceTypeSpecification = value; }
        }

        // Check to see if InstanceTypeSpecification property is set
        internal bool IsSetInstanceTypeSpecification()
        {
            return this._instanceTypeSpecification != null;
        }

    }
}