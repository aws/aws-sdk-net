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
    /// Container for the parameters to the AddApplicationInput operation.
    /// Adds a streaming source to your Amazon Kinesis application. For conceptual information,
    /// see <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-input.html">Configuring
    /// Application Input</a>. 
    /// 
    ///  
    /// <para>
    /// You can add a streaming source either when you create an application or you can use
    /// this operation to add a streaming source after you create an application. For more
    /// information, see <a>CreateApplication</a>.
    /// </para>
    ///  
    /// <para>
    /// Any configuration update, including adding a streaming source using this operation,
    /// results in a new version of the application. You can use the <a>DescribeApplication</a>
    /// operation to find the current application version. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>kinesisanalytics:AddApplicationInput</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class AddApplicationInputRequest : AmazonKinesisAnalyticsRequest
    {
        private string _applicationName;
        private long? _currentApplicationVersionId;
        private Input _input;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// Name of your existing Amazon Kinesis Analytics application to which you want to add
        /// the streaming source.
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
        /// Gets and sets the property CurrentApplicationVersionId. 
        /// <para>
        /// Current version of your Amazon Kinesis Analytics application. You can use the <a>DescribeApplication</a>
        /// operation to find the current application version.
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

        /// <summary>
        /// Gets and sets the property Input.
        /// </summary>
        public Input Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

    }
}