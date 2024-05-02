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
    /// Container for the parameters to the UpdateApplicationMaintenanceConfiguration operation.
    /// Updates the maintenance configuration of the Managed Service for Apache Flink application.
    /// 
    /// 
    ///  
    /// <para>
    /// You can invoke this operation on an application that is in one of the two following
    /// states: <c>READY</c> or <c>RUNNING</c>. If you invoke it when the application is in
    /// a state other than these two states, it throws a <c>ResourceInUseException</c>. The
    /// service makes use of the updated configuration the next time it schedules maintenance
    /// for the application. If you invoke this operation after the service schedules maintenance,
    /// the service will apply the configuration update the next time it schedules maintenance
    /// for the application. This means that you might not see the maintenance configuration
    /// update applied to the maintenance process that follows a successful invocation of
    /// this operation, but to the following maintenance process instead.
    /// </para>
    ///  
    /// <para>
    /// To see the current maintenance configuration of your application, invoke the <a>DescribeApplication</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// For information about application maintenance, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/java/maintenance.html">Managed
    /// Service for Apache Flink for Apache Flink Maintenance</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation is supported only for Managed Service for Apache Flink.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateApplicationMaintenanceConfigurationRequest : AmazonKinesisAnalyticsV2Request
    {
        private ApplicationMaintenanceConfigurationUpdate _applicationMaintenanceConfigurationUpdate;
        private string _applicationName;

        /// <summary>
        /// Gets and sets the property ApplicationMaintenanceConfigurationUpdate. 
        /// <para>
        /// Describes the application maintenance configuration update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApplicationMaintenanceConfigurationUpdate ApplicationMaintenanceConfigurationUpdate
        {
            get { return this._applicationMaintenanceConfigurationUpdate; }
            set { this._applicationMaintenanceConfigurationUpdate = value; }
        }

        // Check to see if ApplicationMaintenanceConfigurationUpdate property is set
        internal bool IsSetApplicationMaintenanceConfigurationUpdate()
        {
            return this._applicationMaintenanceConfigurationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application for which you want to update the maintenance configuration.
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

    }
}