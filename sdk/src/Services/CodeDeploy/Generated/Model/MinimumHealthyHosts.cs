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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about the minimum number of healthy instances.
    /// </summary>
    public partial class MinimumHealthyHosts
    {
        private MinimumHealthyHostsType _type;
        private int? _value;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The minimum healthy instance type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HOST_COUNT</c>: The minimum number of healthy instances as an absolute value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FLEET_PERCENT</c>: The minimum number of healthy instances as a percentage of
        /// the total number of instances in the deployment.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In an example of nine instances, if a HOST_COUNT of six is specified, deploy to up
        /// to three instances at a time. The deployment is successful if six or more instances
        /// are deployed to successfully. Otherwise, the deployment fails. If a FLEET_PERCENT
        /// of 40 is specified, deploy to up to five instances at a time. The deployment is successful
        /// if four or more instances are deployed to successfully. Otherwise, the deployment
        /// fails.
        /// </para>
        ///  <note> 
        /// <para>
        /// In a call to the <c>GetDeploymentConfig</c>, CodeDeployDefault.OneAtATime returns
        /// a minimum healthy instance type of MOST_CONCURRENCY and a value of 1. This means a
        /// deployment to only one instance at a time. (You cannot set the type to MOST_CONCURRENCY,
        /// only to HOST_COUNT or FLEET_PERCENT.) In addition, with CodeDeployDefault.OneAtATime,
        /// CodeDeploy attempts to ensure that all instances but one are kept in a healthy state
        /// during the deployment. Although this allows one instance at a time to be taken offline
        /// for a new deployment, it also means that if the deployment to the last instance fails,
        /// the overall deployment is still successful.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/instances-health.html">CodeDeploy
        /// Instance Health</a> in the <i>CodeDeploy User Guide</i>.
        /// </para>
        /// </summary>
        public MinimumHealthyHostsType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The minimum healthy instance value.
        /// </para>
        /// </summary>
        public int? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}