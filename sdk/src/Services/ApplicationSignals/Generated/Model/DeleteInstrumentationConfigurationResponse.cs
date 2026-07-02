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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// This is the response object from the DeleteInstrumentationConfiguration operation.
    /// </summary>
    public partial class DeleteInstrumentationConfigurationResponse : AmazonWebServiceResponse
    {
        private DynamicInstrumentationDeletionStatus _deletionStatus;

        /// <summary>
        /// Gets and sets the property DeletionStatus. 
        /// <para>
        /// The result of the delete request. The value is <c>DELETED</c> when the configuration
        /// has been removed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DynamicInstrumentationDeletionStatus DeletionStatus
        {
            get { return this._deletionStatus; }
            set { this._deletionStatus = value; }
        }

        // Check to see if DeletionStatus property is set
        internal bool IsSetDeletionStatus()
        {
            return this._deletionStatus != null;
        }

    }
}