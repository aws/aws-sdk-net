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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFramework operation.
    /// Updates an existing framework identified by its <code>FrameworkName</code> with the
    /// input document in JSON format.
    /// </summary>
    public partial class UpdateFrameworkRequest : AmazonBackupRequest
    {
        private List<FrameworkControl> _frameworkControls = new List<FrameworkControl>();
        private string _frameworkDescription;
        private string _frameworkName;
        private string _idempotencyToken;

        /// <summary>
        /// Gets and sets the property FrameworkControls. 
        /// <para>
        /// A list of the controls that make up the framework. Each control in the list has a
        /// name, input parameters, and scope.
        /// </para>
        /// </summary>
        public List<FrameworkControl> FrameworkControls
        {
            get { return this._frameworkControls; }
            set { this._frameworkControls = value; }
        }

        // Check to see if FrameworkControls property is set
        internal bool IsSetFrameworkControls()
        {
            return this._frameworkControls != null && this._frameworkControls.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FrameworkDescription. 
        /// <para>
        /// An optional description of the framework with a maximum 1,024 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FrameworkDescription
        {
            get { return this._frameworkDescription; }
            set { this._frameworkDescription = value; }
        }

        // Check to see if FrameworkDescription property is set
        internal bool IsSetFrameworkDescription()
        {
            return this._frameworkDescription != null;
        }

        /// <summary>
        /// Gets and sets the property FrameworkName. 
        /// <para>
        /// The unique name of a framework. This name is between 1 and 256 characters, starting
        /// with a letter, and consisting of letters (a-z, A-Z), numbers (0-9), and underscores
        /// (_).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string FrameworkName
        {
            get { return this._frameworkName; }
            set { this._frameworkName = value; }
        }

        // Check to see if FrameworkName property is set
        internal bool IsSetFrameworkName()
        {
            return this._frameworkName != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A customer-chosen string that you can use to distinguish between otherwise identical
        /// calls to <code>UpdateFrameworkInput</code>. Retrying a successful request with the
        /// same idempotency token results in a success message with no action taken.
        /// </para>
        /// </summary>
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

    }
}