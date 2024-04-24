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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// An error or warning for the operation.
    /// </summary>
    public partial class DashboardValidationMessage
    {
        private string _dataPath;
        private string _message;

        /// <summary>
        /// Gets and sets the property DataPath. 
        /// <para>
        /// The data path related to the message.
        /// </para>
        /// </summary>
        public string DataPath
        {
            get { return this._dataPath; }
            set { this._dataPath = value; }
        }

        // Check to see if DataPath property is set
        internal bool IsSetDataPath()
        {
            return this._dataPath != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message describing the error or warning.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}