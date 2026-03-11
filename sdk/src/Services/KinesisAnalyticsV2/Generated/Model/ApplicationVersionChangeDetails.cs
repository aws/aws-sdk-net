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
    /// Contains information about the version changes that the operation applied to the application.
    /// </summary>
    public partial class ApplicationVersionChangeDetails
    {
        private long? _applicationVersionUpdatedFrom;
        private long? _applicationVersionUpdatedTo;

        /// <summary>
        /// Gets and sets the property ApplicationVersionUpdatedFrom. 
        /// <para>
        /// The new version that the application was updated to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=999999999)]
        public long? ApplicationVersionUpdatedFrom
        {
            get { return this._applicationVersionUpdatedFrom; }
            set { this._applicationVersionUpdatedFrom = value; }
        }

        // Check to see if ApplicationVersionUpdatedFrom property is set
        internal bool IsSetApplicationVersionUpdatedFrom()
        {
            return this._applicationVersionUpdatedFrom.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ApplicationVersionUpdatedTo. 
        /// <para>
        /// The version that the operation execution applied to the applicartion.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=999999999)]
        public long? ApplicationVersionUpdatedTo
        {
            get { return this._applicationVersionUpdatedTo; }
            set { this._applicationVersionUpdatedTo = value; }
        }

        // Check to see if ApplicationVersionUpdatedTo property is set
        internal bool IsSetApplicationVersionUpdatedTo()
        {
            return this._applicationVersionUpdatedTo.HasValue; 
        }

    }
}