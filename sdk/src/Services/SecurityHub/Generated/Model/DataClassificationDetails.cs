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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about sensitive data that was detected on a resource.
    /// </summary>
    public partial class DataClassificationDetails
    {
        private string _detailedResultsLocation;
        private ClassificationResult _result;

        /// <summary>
        /// Gets and sets the property DetailedResultsLocation. 
        /// <para>
        /// The path to the folder or file that contains the sensitive data.
        /// </para>
        /// </summary>
        public string DetailedResultsLocation
        {
            get { return this._detailedResultsLocation; }
            set { this._detailedResultsLocation = value; }
        }

        // Check to see if DetailedResultsLocation property is set
        internal bool IsSetDetailedResultsLocation()
        {
            return this._detailedResultsLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The details about the sensitive data that was detected on the resource.
        /// </para>
        /// </summary>
        public ClassificationResult Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

    }
}