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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Contains information associated with an Amazon CloudWatch event destination to which
    /// email sending events are published.
    /// 
    ///  
    /// <para>
    /// Event destinations, such as Amazon CloudWatch, are associated with configuration sets,
    /// which enable you to publish email sending events. For information about using configuration
    /// sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class CloudWatchDestination
    {
        private List<CloudWatchDimensionConfiguration> _dimensionConfigurations = AWSConfigs.InitializeCollections ? new List<CloudWatchDimensionConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property DimensionConfigurations. 
        /// <para>
        /// A list of dimensions upon which to categorize your emails when you publish email sending
        /// events to Amazon CloudWatch.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<CloudWatchDimensionConfiguration> DimensionConfigurations
        {
            get { return this._dimensionConfigurations; }
            set { this._dimensionConfigurations = value; }
        }

        // Check to see if DimensionConfigurations property is set
        internal bool IsSetDimensionConfigurations()
        {
            return this._dimensionConfigurations != null && (this._dimensionConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}