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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// This is the response object from the GetDependencyInsights operation.
    /// </summary>
    public partial class GetDependencyInsightsResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private DependencyInsightsErrorCode _errorCode;
        private string _errorMessage;
        private List<DependencyInsight> _insights = AWSConfigs.InitializeCollections ? new List<DependencyInsight>() : null;
        private string _overview;
        private DependencyInsightsStatus _status;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the dependency insights were generated.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code returned when insights generation failed. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// INSUFFICIENT_DATA - There was not enough dependency data to generate insights.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LLM_GENERATION_FAILED - The insights could not be generated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INTERNAL_ERROR - An internal error occurred while generating insights.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DependencyInsightsErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A message describing why insights generation failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Insights. 
        /// <para>
        /// The list of dependency insights generated for the service. This field is not returned
        /// until the status is COMPLETED.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<DependencyInsight> Insights
        {
            get { return this._insights; }
            set { this._insights = value; }
        }

        // Check to see if Insights property is set
        internal bool IsSetInsights()
        {
            return this._insights != null && (this._insights.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Overview. 
        /// <para>
        /// A summary of the dependency insights for the service. This field is not returned until
        /// the status is COMPLETED.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
        public string Overview
        {
            get { return this._overview; }
            set { this._overview = value; }
        }

        // Check to see if Overview property is set
        internal bool IsSetOverview()
        {
            return this._overview != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the dependency insights generation. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// IN_PROGRESS - Insights generation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// COMPLETED - Insights generation completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED - Insights generation failed. See errorCode and errorMessage for details.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public DependencyInsightsStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}