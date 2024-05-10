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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Container for the parameters to the StopApplication operation.
    /// Stops the application from processing data. You can stop an application only if it
    /// is in the running status, unless you set the <c>Force</c> parameter to <c>true</c>.
    /// 
    ///  
    /// <para>
    /// You can use the <a>DescribeApplication</a> operation to find the application status.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Managed Service for Apache Flink takes a snapshot when the application is stopped,
    /// unless <c>Force</c> is set to <c>true</c>.
    /// </para>
    /// </summary>
    public partial class StopApplicationRequest : AmazonKinesisAnalyticsV2Request
    {
        private string _applicationName;
        private bool? _force;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the running application to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property Force. 
        /// <para>
        /// Set to <c>true</c> to force the application to stop. If you set <c>Force</c> to <c>true</c>,
        /// Managed Service for Apache Flink stops the application without taking a snapshot.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Force-stopping your application may lead to data loss or duplication. To prevent data
        /// loss or duplicate processing of data during application restarts, we recommend you
        /// to take frequent snapshots of your application.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can only force stop a Managed Service for Apache Flink application. You can't
        /// force stop a SQL-based Kinesis Data Analytics application.
        /// </para>
        ///  
        /// <para>
        /// The application must be in the <c>STARTING</c>, <c>UPDATING</c>, <c>STOPPING</c>,
        /// <c>AUTOSCALING</c>, or <c>RUNNING</c> status. 
        /// </para>
        /// </summary>
        public bool? Force
        {
            get { return this._force; }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

    }
}