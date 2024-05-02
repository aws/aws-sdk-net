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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// A lifecycle rule that deletes the oldest application version when the maximum count
    /// is exceeded.
    /// </summary>
    public partial class MaxCountRule
    {
        private bool? _deleteSourceFromS3;
        private bool? _enabled;
        private int? _maxCount;

        /// <summary>
        /// Gets and sets the property DeleteSourceFromS3. 
        /// <para>
        /// Set to <c>true</c> to delete a version's source bundle from Amazon S3 when Elastic
        /// Beanstalk deletes the application version.
        /// </para>
        /// </summary>
        public bool? DeleteSourceFromS3
        {
            get { return this._deleteSourceFromS3; }
            set { this._deleteSourceFromS3 = value; }
        }

        // Check to see if DeleteSourceFromS3 property is set
        internal bool IsSetDeleteSourceFromS3()
        {
            return this._deleteSourceFromS3.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specify <c>true</c> to apply the rule, or <c>false</c> to disable it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxCount. 
        /// <para>
        /// Specify the maximum number of application versions to retain.
        /// </para>
        /// </summary>
        public int? MaxCount
        {
            get { return this._maxCount; }
            set { this._maxCount = value; }
        }

        // Check to see if MaxCount property is set
        internal bool IsSetMaxCount()
        {
            return this._maxCount.HasValue; 
        }

    }
}