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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the GenerateChangeSet operation.
    /// Generates a target change set for a currently launched stack and writes it to an Amazon
    /// S3 object in the customer’s Amazon S3 bucket.
    /// </summary>
    public partial class GenerateChangeSetRequest : AmazonServerMigrationServiceRequest
    {
        private string _appId;
        private OutputFormat _changesetFormat;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// ID of the application associated with the change set.
        /// </para>
        /// </summary>
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property ChangesetFormat. 
        /// <para>
        /// Format for the change set.
        /// </para>
        /// </summary>
        public OutputFormat ChangesetFormat
        {
            get { return this._changesetFormat; }
            set { this._changesetFormat = value; }
        }

        // Check to see if ChangesetFormat property is set
        internal bool IsSetChangesetFormat()
        {
            return this._changesetFormat != null;
        }

    }
}