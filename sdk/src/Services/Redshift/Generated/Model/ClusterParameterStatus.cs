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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes the status of a parameter group.
    /// </summary>
    public partial class ClusterParameterStatus
    {
        private string _parameterApplyErrorDescription;
        private string _parameterApplyStatus;
        private string _parameterName;

        /// <summary>
        /// Gets and sets the property ParameterApplyErrorDescription. 
        /// <para>
        /// The error that prevented the parameter from being applied to the database.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ParameterApplyErrorDescription
        {
            get { return this._parameterApplyErrorDescription; }
            set { this._parameterApplyErrorDescription = value; }
        }

        // Check to see if ParameterApplyErrorDescription property is set
        internal bool IsSetParameterApplyErrorDescription()
        {
            return this._parameterApplyErrorDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterApplyStatus. 
        /// <para>
        /// The status of the parameter that indicates whether the parameter is in sync with the
        /// database, waiting for a cluster reboot, or encountered an error when being applied.
        /// </para>
        ///  
        /// <para>
        /// The following are possible statuses and descriptions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>in-sync</c>: The parameter value is in sync with the database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending-reboot</c>: The parameter value will be applied after the cluster reboots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>applying</c>: The parameter value is being applied to the database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>invalid-parameter</c>: Cannot apply the parameter value because it has an invalid
        /// value or syntax.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>apply-deferred</c>: The parameter contains static property changes. The changes
        /// are deferred until the cluster reboots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>apply-error</c>: Cannot connect to the cluster. The parameter change will be applied
        /// after the cluster reboots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unknown-error</c>: Cannot apply the parameter change right now. The change will
        /// be applied after the cluster reboots.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ParameterApplyStatus
        {
            get { return this._parameterApplyStatus; }
            set { this._parameterApplyStatus = value; }
        }

        // Check to see if ParameterApplyStatus property is set
        internal bool IsSetParameterApplyStatus()
        {
            return this._parameterApplyStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// The name of the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ParameterName
        {
            get { return this._parameterName; }
            set { this._parameterName = value; }
        }

        // Check to see if ParameterName property is set
        internal bool IsSetParameterName()
        {
            return this._parameterName != null;
        }

    }
}