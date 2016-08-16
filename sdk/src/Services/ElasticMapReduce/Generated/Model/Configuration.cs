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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
    /// <note> 
    /// <para>
    /// Amazon EMR releases 4.x or later.
    /// </para>
    ///  </note> 
    /// <para>
    /// Specifies a hardware and software configuration of the EMR cluster. This includes
    /// configurations for applications and software bundled with Amazon EMR. The Configuration
    /// object is a JSON object which is defined by a classification and a set of properties.
    /// Configurations can be nested, so a configuration may have its own Configuration objects
    /// listed.
    /// </para>
    /// </summary>
    public partial class Configuration
    {
        private string _classification;
        private List<Configuration> _configurations = new List<Configuration>();
        private Dictionary<string, string> _properties = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Classification. 
        /// <para>
        /// The classification of a configuration. For more information see, <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/API/EmrConfigurations.html">Amazon
        /// EMR Configurations</a>. 
        /// </para>
        /// </summary>
        public string Classification
        {
            get { return this._classification; }
            set { this._classification = value; }
        }

        // Check to see if Classification property is set
        internal bool IsSetClassification()
        {
            return this._classification != null;
        }

        /// <summary>
        /// Gets and sets the property Configurations. 
        /// <para>
        /// A list of configurations you apply to this configuration object.
        /// </para>
        /// </summary>
        public List<Configuration> Configurations
        {
            get { return this._configurations; }
            set { this._configurations = value; }
        }

        // Check to see if Configurations property is set
        internal bool IsSetConfigurations()
        {
            return this._configurations != null && this._configurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A set of properties supplied to the Configuration object.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && this._properties.Count > 0; 
        }

    }
}