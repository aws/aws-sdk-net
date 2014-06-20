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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// This represents a step in a cluster.
    /// </summary>
    public partial class Step
    {
        private string _actionOnFailure;
        private HadoopStepConfig _config;
        private string _id;
        private string _name;
        private StepStatus _status;


        /// <summary>
        /// Gets and sets the property ActionOnFailure. 
        /// <para>
        /// This specifies what action to take when the cluster step fails. Possible values are
        /// TERMINATE_CLUSTER, CANCEL_AND_WAIT, and CONTINUE.         
        /// </para>
        /// </summary>
        public string ActionOnFailure
        {
            get { return this._actionOnFailure; }
            set { this._actionOnFailure = value; }
        }


        /// <summary>
        /// Sets the ActionOnFailure property
        /// </summary>
        /// <param name="actionOnFailure">The value to set for the ActionOnFailure property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Step WithActionOnFailure(string actionOnFailure)
        {
            this._actionOnFailure = actionOnFailure;
            return this;
        }

        // Check to see if ActionOnFailure property is set
        internal bool IsSetActionOnFailure()
        {
            return this._actionOnFailure != null;
        }


        /// <summary>
        /// Gets and sets the property Config. 
        /// <para>
        /// The Hadoop job configuration of the cluster step.      
        /// </para>
        /// </summary>
        public HadoopStepConfig Config
        {
            get { return this._config; }
            set { this._config = value; }
        }


        /// <summary>
        /// Sets the Config property
        /// </summary>
        /// <param name="config">The value to set for the Config property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Step WithConfig(HadoopStepConfig config)
        {
            this._config = config;
            return this;
        }

        // Check to see if Config property is set
        internal bool IsSetConfig()
        {
            return this._config != null;
        }


        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the cluster step.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }


        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Step WithId(string id)
        {
            this._id = id;
            return this;
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }


        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cluster step.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Step WithName(string name)
        {
            this._name = name;
            return this;
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }


        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current execution status details of the cluster step.      
        /// </para>
        /// </summary>
        public StepStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }


        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Step WithStatus(StepStatus status)
        {
            this._status = status;
            return this;
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}