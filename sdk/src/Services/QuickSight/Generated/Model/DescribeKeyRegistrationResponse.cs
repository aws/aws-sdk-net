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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the DescribeKeyRegistration operation.
    /// </summary>
    public partial class DescribeKeyRegistrationResponse : AmazonWebServiceResponse
    {
        private string _awsAccountId;
        private List<RegisteredCustomerManagedKey> _keyRegistration = AWSConfigs.InitializeCollections ? new List<RegisteredCustomerManagedKey>() : null;
        private QDataKey _qDataKey;
        private string _requestId;
        private int? _status;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the customer managed key registration
        /// specified in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property KeyRegistration. 
        /// <para>
        /// A list of <c>RegisteredCustomerManagedKey</c> objects in a Quick Sight account.
        /// </para>
        /// </summary>
        public List<RegisteredCustomerManagedKey> KeyRegistration
        {
            get { return this._keyRegistration; }
            set { this._keyRegistration = value; }
        }

        // Check to see if KeyRegistration property is set
        internal bool IsSetKeyRegistration()
        {
            return this._keyRegistration != null && (this._keyRegistration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QDataKey. 
        /// <para>
        /// A list of <c>QDataKey</c> objects in a Quick Sight account.
        /// </para>
        /// </summary>
        public QDataKey QDataKey
        {
            get { return this._qDataKey; }
            set { this._qDataKey = value; }
        }

        // Check to see if QDataKey property is set
        internal bool IsSetQDataKey()
        {
            return this._qDataKey != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int Status
        {
            get { return this._status.GetValueOrDefault(); }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

    }
}