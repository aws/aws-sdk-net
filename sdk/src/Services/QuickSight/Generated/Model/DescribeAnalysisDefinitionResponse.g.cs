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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the DescribeAnalysisDefinition operation.
    /// </summary>
    public partial class DescribeAnalysisDefinitionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AnalysisId. 
        /// <para>
        /// The ID of the analysis described.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string AnalysisId { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisId property is set.
        /// </summary>
        internal bool IsSetAnalysisId() => this.AnalysisId != null;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The definition of an analysis.
        /// </para>
        ///  
        /// <para>
        /// A definition is the data model of all features in a Dashboard, Template, or Analysis.
        /// </para>
        /// </summary>
        public AnalysisDefinition Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Errors associated with the analysis.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<AnalysisError> Errors { get; set; } = AWSConfigs.InitializeCollections ? new List<AnalysisError>() : null;

        /// <summary>
        /// Checks to see if the Errors property is set.
        /// </summary>
        internal bool IsSetErrors() => this.Errors != null && (this.Errors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The descriptive name of the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property ResourceStatus. 
        /// <para>
        /// Status associated with the analysis.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATION_IN_PROGRESS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATION_SUCCESSFUL</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATION_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_IN_PROGRESS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_SUCCESSFUL</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceStatus ResourceStatus { get; set; }

        /// <summary>
        /// Checks to see if the ResourceStatus property is set.
        /// </summary>
        internal bool IsSetResourceStatus() => this.ResourceStatus != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status.HasValue;

        /// <summary>
        /// Gets and sets the property ThemeArn. 
        /// <para>
        /// The ARN of the theme of the analysis.
        /// </para>
        /// </summary>
        public string ThemeArn { get; set; }

        /// <summary>
        /// Checks to see if the ThemeArn property is set.
        /// </summary>
        internal bool IsSetThemeArn() => this.ThemeArn != null;
    }
}
