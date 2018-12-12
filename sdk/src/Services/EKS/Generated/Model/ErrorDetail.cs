/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EKS.Model
{
    /// <summary>
    /// An object representing an error when an asynchronous operation fails.
    /// </summary>
    public partial class ErrorDetail
    {
        private ErrorCode _errorCode;
        private string _errorMessage;
        private List<string> _resourceIds = new List<string>();

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// A brief description of the error. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>SubnetNotFound</b>: One of the subnets associated with the cluster could not be
        /// found.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SecurityGroupNotFound</b>: One of the security groups associated with the cluster
        /// could not be found.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>EniLimitReached</b>: You have reached the elastic network interface limit for
        /// your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IpNotAvailable</b>: A subnet associated with the cluster does not have any free
        /// IP addresses.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AccessDenied</b>: You do not have permissions to perform the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>OperationNotPermitted</b>: The service role associated with the cluster does not
        /// have the required access permissions for Amazon EKS.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>VpcIdNotFound</b>: The VPC associated with the cluster could not be found.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A more complete description of the error.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIds. 
        /// <para>
        /// An optional field that contains the resource IDs associated with the error.
        /// </para>
        /// </summary>
        public List<string> ResourceIds
        {
            get { return this._resourceIds; }
            set { this._resourceIds = value; }
        }

        // Check to see if ResourceIds property is set
        internal bool IsSetResourceIds()
        {
            return this._resourceIds != null && this._resourceIds.Count > 0; 
        }

    }
}