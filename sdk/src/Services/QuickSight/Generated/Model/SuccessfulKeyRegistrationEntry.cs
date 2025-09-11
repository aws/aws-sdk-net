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
    /// A success entry that occurs when a <c>KeyRegistration</c> job is successfully applied
    /// to the QuickSight account.
    /// </summary>
    public partial class SuccessfulKeyRegistrationEntry
    {
        private string _keyArn;
        private int? _statusCode;

        /// <summary>
        /// Gets and sets the property KeyArn. 
        /// <para>
        /// The ARN of the KMS key that is associated with the <c>SuccessfulKeyRegistrationEntry</c>
        /// entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KeyArn
        {
            get { return this._keyArn; }
            set { this._keyArn = value; }
        }

        // Check to see if KeyArn property is set
        internal bool IsSetKeyArn()
        {
            return this._keyArn != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The HTTP status of a <c>SuccessfulKeyRegistrationEntry</c> entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode.HasValue; 
        }

    }
}