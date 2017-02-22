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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that identifies the CloudWatch alarm that you want Amazon Route 53
    /// health checkers to use to determine whether this health check is healthy.
    /// </summary>
    public partial class AlarmIdentifier
    {
        private CloudWatchRegion _region;
        private string _name;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// A complex type that identifies the CloudWatch alarm that you want Amazon Route 53
        /// health checkers to use to determine whether this health check is healthy.
        /// </para>
        ///  
        /// <para>
        /// For the current list of CloudWatch regions, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#cw_region">Amazon
        /// CloudWatch</a> in the <i>AWS Regions and Endpoints</i> chapter of the <i>Amazon Web
        /// Services General Reference</i>.
        /// </para>
        /// </summary>
        public CloudWatchRegion Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the CloudWatch alarm that you want Amazon Route 53 health checkers to
        /// use to determine whether this health check is healthy.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}