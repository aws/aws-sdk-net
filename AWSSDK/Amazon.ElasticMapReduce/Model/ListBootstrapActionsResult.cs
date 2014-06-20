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
    /// This output contains the boostrap actions detail      .
    /// </summary>
    public partial class ListBootstrapActionsResult
    {
        private List<Command> _bootstrapActions = new List<Command>();
        private string _marker;


        /// <summary>
        /// Gets and sets the property BootstrapActions. 
        /// <para>
        /// The bootstrap actions associated with the cluster      .
        /// </para>
        /// </summary>
        public List<Command> BootstrapActions
        {
            get { return this._bootstrapActions; }
            set { this._bootstrapActions = value; }
        }

        /// <summary>
        /// Sets the BootstrapActions property
        /// </summary>
        /// <param name="bootstrapActions">The values to add to the BootstrapActions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListBootstrapActionsResult WithBootstrapActions(params Command[] bootstrapActions)
        {
            foreach (var element in bootstrapActions)
            {
                this._bootstrapActions.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the BootstrapActions property
        /// </summary>
        /// <param name="bootstrapActions">The values to add to the BootstrapActions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListBootstrapActionsResult WithBootstrapActions(IEnumerable<Command> bootstrapActions)
        {
            foreach (var element in bootstrapActions)
            {
                this._bootstrapActions.Add(element);
            }
            return this;
        }
        // Check to see if BootstrapActions property is set
        internal bool IsSetBootstrapActions()
        {
            return this._bootstrapActions != null && this._bootstrapActions.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The pagination token that indicates the next set of results to retrieve      .
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }


        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListBootstrapActionsResult WithMarker(string marker)
        {
            this._marker = marker;
            return this;
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}