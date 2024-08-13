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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
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
namespace Amazon.Snowball.Model
{
    /// <summary>
    /// This is the response object from the DescribeReturnShippingLabel operation.
    /// </summary>
    public partial class DescribeReturnShippingLabelResponse : AmazonWebServiceResponse
    {
        private DateTime? _expirationDate;
        private string _returnShippingLabelURI;
        private ShippingLabelStatus _status;

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The expiration date of the current return shipping label.
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate
        {
            get { return this._expirationDate; }
            set { this._expirationDate = value; }
        }

        // Check to see if ExpirationDate property is set
        internal bool IsSetExpirationDate()
        {
            return this._expirationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReturnShippingLabelURI. 
        /// <para>
        /// The pre-signed Amazon S3 URI used to download the return shipping label.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ReturnShippingLabelURI
        {
            get { return this._returnShippingLabelURI; }
            set { this._returnShippingLabelURI = value; }
        }

        // Check to see if ReturnShippingLabelURI property is set
        internal bool IsSetReturnShippingLabelURI()
        {
            return this._returnShippingLabelURI != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status information of the task on a Snow device that is being returned to Amazon
        /// Web Services.
        /// </para>
        /// </summary>
        public ShippingLabelStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}