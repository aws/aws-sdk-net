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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApplication operation.
    /// Updates an existing Kinesis Analytics application. Using this API, you can update
    /// application code, input configuration, and output configuration. 
    /// 
    ///  
    /// <para>
    /// Note that Kinesis Analytics updates the <code>CurrentApplicationVersionId</code> each
    /// time you update your application. 
    /// </para>
    ///  
    /// <para>
    /// This opeation requires permission for the <code>kinesisanalytics:UpdateApplication</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class UpdateApplicationRequest : AmazonKinesisAnalyticsRequest
    {
        private string _applicationName;
        private ApplicationUpdate _applicationUpdate;
        private long? _currentApplicationVersionId;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// Name of the Kinesis Analytics application to update.
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationUpdate. 
        /// <para>
        /// Describes application updates.
        /// </para>
        /// </summary>
        public ApplicationUpdate ApplicationUpdate
        {
            get { return this._applicationUpdate; }
            set { this._applicationUpdate = value; }
        }

        // Check to see if ApplicationUpdate property is set
        internal bool IsSetApplicationUpdate()
        {
            return this._applicationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentApplicationVersionId. 
        /// <para>
        /// The current application version ID. You can use the <a>DescribeApplication</a> operation
        /// to get this value.
        /// </para>
        /// </summary>
        public long CurrentApplicationVersionId
        {
            get { return this._currentApplicationVersionId.GetValueOrDefault(); }
            set { this._currentApplicationVersionId = value; }
        }

        // Check to see if CurrentApplicationVersionId property is set
        internal bool IsSetCurrentApplicationVersionId()
        {
            return this._currentApplicationVersionId.HasValue; 
        }

    }
}