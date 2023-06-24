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
    /// This is the response object from the UpdateFramework operation.
    /// </summary>
    public partial class UpdateFrameworkResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _frameworkArn;
        private string _frameworkName;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that a framework is created, in ISO 8601 representation. The value
        /// of <code>CreationTime</code> is accurate to milliseconds. For example, 2020-07-10T15:00:00.000-08:00
        /// represents the 10th of July 2020 at 3:00 PM 8 hours behind UTC.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FrameworkArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a resource. The format of the
        /// ARN depends on the resource type.
        /// </para>
        /// </summary>
        public string FrameworkArn
        {
            get { return this._frameworkArn; }
            set { this._frameworkArn = value; }
        }

        // Check to see if FrameworkArn property is set
        internal bool IsSetFrameworkArn()
        {
            return this._frameworkArn != null;
        }

        /// <summary>
        /// Gets and sets the property FrameworkName. 
        /// <para>
        /// The unique name of a framework. This name is between 1 and 256 characters, starting
        /// with a letter, and consisting of letters (a-z, A-Z), numbers (0-9), and underscores
        /// (_).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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

    }
}