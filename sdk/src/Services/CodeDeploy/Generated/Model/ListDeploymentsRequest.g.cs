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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListDeployments operation. Lists the deployments
    /// in a deployment group for an application registered with the user or Amazon Web Services
    /// account.
    /// </summary>
    public partial class ListDeploymentsRequest : AmazonCodeDeployRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of an CodeDeploy application associated with the user or Amazon Web Services
        /// account.
        /// </para>
        ///  <note> 
        /// <para>
        /// If <c>applicationName</c> is specified, then <c>deploymentGroupName</c> must be specified.
        /// If it is not specified, then <c>deploymentGroupName</c> must not be specified. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property CreateTimeRange. 
        /// <para>
        /// A time range (start and end) for returning a subset of the list of deployments.
        /// </para>
        /// </summary>
        public TimeRange CreateTimeRange { get; set; }

        /// <summary>
        /// Checks to see if the CreateTimeRange property is set.
        /// </summary>
        internal bool IsSetCreateTimeRange() => this.CreateTimeRange != null;

        /// <summary>
        /// Gets and sets the property DeploymentGroupName. 
        /// <para>
        /// The name of a deployment group for the specified application.
        /// </para>
        ///  <note> 
        /// <para>
        /// If <c>deploymentGroupName</c> is specified, then <c>applicationName</c> must be specified.
        /// If it is not specified, then <c>applicationName</c> must not be specified. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string DeploymentGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentGroupName property is set.
        /// </summary>
        internal bool IsSetDeploymentGroupName() => this.DeploymentGroupName != null;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The unique ID of an external resource for returning deployments linked to the external
        /// resource.
        /// </para>
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;

        /// <summary>
        /// Gets and sets the property IncludeOnlyStatuses. 
        /// <para>
        /// A subset of deployments to list by status:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Created</c>: Include created deployments in the resulting list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Queued</c>: Include queued deployments in the resulting list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>In Progress</c>: Include in-progress deployments in the resulting list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Succeeded</c>: Include successful deployments in the resulting list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c>: Include failed deployments in the resulting list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Stopped</c>: Include stopped deployments in the resulting list.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IncludeOnlyStatuses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IncludeOnlyStatuses property is set.
        /// </summary>
        internal bool IsSetIncludeOnlyStatuses() => this.IncludeOnlyStatuses != null && (this.IncludeOnlyStatuses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier returned from the previous list deployments call. It can be used to
        /// return the next set of deployments in the list.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
