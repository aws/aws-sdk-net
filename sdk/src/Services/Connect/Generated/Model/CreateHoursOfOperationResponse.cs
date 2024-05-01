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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the CreateHoursOfOperation operation.
    /// </summary>
    public partial class CreateHoursOfOperationResponse : AmazonWebServiceResponse
    {
        private string _hoursOfOperationArn;
        private string _hoursOfOperationId;

        /// <summary>
        /// Gets and sets the property HoursOfOperationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the hours of operation.
        /// </para>
        /// </summary>
        public string HoursOfOperationArn
        {
            get { return this._hoursOfOperationArn; }
            set { this._hoursOfOperationArn = value; }
        }

        // Check to see if HoursOfOperationArn property is set
        internal bool IsSetHoursOfOperationArn()
        {
            return this._hoursOfOperationArn != null;
        }

        /// <summary>
        /// Gets and sets the property HoursOfOperationId. 
        /// <para>
        /// The identifier for the hours of operation.
        /// </para>
        /// </summary>
        public string HoursOfOperationId
        {
            get { return this._hoursOfOperationId; }
            set { this._hoursOfOperationId = value; }
        }

        // Check to see if HoursOfOperationId property is set
        internal bool IsSetHoursOfOperationId()
        {
            return this._hoursOfOperationId != null;
        }

    }
}