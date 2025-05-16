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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// This is the response object from the DescribePersistentAppUI operation.
    /// </summary>
    public partial class DescribePersistentAppUIResponse : AmazonWebServiceResponse
    {
        private PersistentAppUI _persistentAppUI;

        /// <summary>
        /// Gets and sets the property PersistentAppUI. 
        /// <para>
        /// The persistent application user interface.
        /// </para>
        /// </summary>
        public PersistentAppUI PersistentAppUI
        {
            get { return this._persistentAppUI; }
            set { this._persistentAppUI = value; }
        }

        // Check to see if PersistentAppUI property is set
        internal bool IsSetPersistentAppUI()
        {
            return this._persistentAppUI != null;
        }

    }
}