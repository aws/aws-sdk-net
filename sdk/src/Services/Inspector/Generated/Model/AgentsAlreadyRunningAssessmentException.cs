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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// You started an assessment run, but one of the instances is already participating in
    /// another assessment run.
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class AgentsAlreadyRunningAssessmentException : AmazonInspectorException
    {
        private List<AgentAlreadyRunningAssessment> _agents = AWSConfigs.InitializeCollections ? new List<AgentAlreadyRunningAssessment>() : null;
        private bool? _agentsTruncated;
        private bool? _canRetry;

        /// <summary>
        /// Constructs a new AgentsAlreadyRunningAssessmentException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public AgentsAlreadyRunningAssessmentException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of AgentsAlreadyRunningAssessmentException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public AgentsAlreadyRunningAssessmentException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of AgentsAlreadyRunningAssessmentException
        /// </summary>
        /// <param name="innerException"></param>
        public AgentsAlreadyRunningAssessmentException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of AgentsAlreadyRunningAssessmentException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public AgentsAlreadyRunningAssessmentException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of AgentsAlreadyRunningAssessmentException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public AgentsAlreadyRunningAssessmentException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the AgentsAlreadyRunningAssessmentException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected AgentsAlreadyRunningAssessmentException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.Agents = (List<AgentAlreadyRunningAssessment>)info.GetValue("Agents", typeof(List<AgentAlreadyRunningAssessment>));
            this.AgentsTruncated = (bool?)info.GetValue("AgentsTruncated", typeof(bool?));
            this.CanRetry = (bool?)info.GetValue("CanRetry", typeof(bool?));
        }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception>
        [System.Security.SecurityCritical]
        // These FxCop rules are giving false-positives for this method
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2134:MethodsMustOverrideWithConsistentTransparencyFxCopRule")]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Agents", this.Agents);
            info.AddValue("AgentsTruncated", this.AgentsTruncated);
            info.AddValue("CanRetry", this.CanRetry);
        }
#endif

        /// <summary>
        /// Gets and sets the property Agents.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<AgentAlreadyRunningAssessment> Agents
        {
            get { return this._agents; }
            set { this._agents = value; }
        }

        // Check to see if Agents property is set
        internal bool IsSetAgents()
        {
            return this._agents != null && (this._agents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AgentsTruncated.
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? AgentsTruncated
        {
            get { return this._agentsTruncated; }
            set { this._agentsTruncated = value; }
        }

        // Check to see if AgentsTruncated property is set
        internal bool IsSetAgentsTruncated()
        {
            return this._agentsTruncated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CanRetry. 
        /// <para>
        /// You can immediately retry your request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? CanRetry
        {
            get { return this._canRetry; }
            set { this._canRetry = value; }
        }

        // Check to see if CanRetry property is set
        internal bool IsSetCanRetry()
        {
            return this._canRetry.HasValue; 
        }

    }
}