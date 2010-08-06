/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-01-01
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.RDS.Model
{
    ///<summary>
    ///Information about the engine defaults.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/doc/2010-01-01/", IsNullable = false)]
    public class EngineDefaults
    {
        private string engineField;
        private string markerField;
        private List<Parameter> parameterField;

        /// <summary>
        /// Gets and sets the Engine property.
        /// Name of the database engine for which the parameters apply.
        /// </summary>
        [XmlElementAttribute(ElementName = "Engine")]
        public string Engine
        {
            get { return this.engineField; }
            set { this.engineField = value; }
        }

        /// <summary>
        /// Sets the Engine property
        /// </summary>
        /// <param name="engine">Name of the database engine for which the parameters apply.</param>
        /// <returns>this instance</returns>
        public EngineDefaults WithEngine(string engine)
        {
            this.engineField = engine;
            return this;
        }

        /// <summary>
        /// Checks if Engine property is set
        /// </summary>
        /// <returns>true if Engine property is set</returns>
        public bool IsSetEngine()
        {
            return this.engineField != null;
        }

        /// <summary>
        /// Gets and sets the Marker property.
        /// Identifier returned to allow retrieval of paginated results.
        /// </summary>
        [XmlElementAttribute(ElementName = "Marker")]
        public string Marker
        {
            get { return this.markerField; }
            set { this.markerField = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">Identifier returned to allow retrieval of paginated results.</param>
        /// <returns>this instance</returns>
        public EngineDefaults WithMarker(string marker)
        {
            this.markerField = marker;
            return this;
        }

        /// <summary>
        /// Checks if Marker property is set
        /// </summary>
        /// <returns>true if Marker property is set</returns>
        public bool IsSetMarker()
        {
            return this.markerField != null;
        }

        /// <summary>
        /// Gets and sets the Parameter property.
        /// List of parameters contained in parameter sub-elements.
        /// </summary>
        [XmlElementAttribute(ElementName = "Parameter")]
        public List<Parameter> Parameter
        {
            get
            {
                if (this.parameterField == null)
                {
                    this.parameterField = new List<Parameter>();
                }
                return this.parameterField;
            }
            set { this.parameterField = value; }
        }

        /// <summary>
        /// Sets the Parameter property
        /// </summary>
        /// <param name="list">List of parameters contained in parameter sub-elements.</param>
        /// <returns>this instance</returns>
        public EngineDefaults WithParameter(params Parameter[] list)
        {
            foreach (Parameter item in list)
            {
                Parameter.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Parameter property is set
        /// </summary>
        /// <returns>true if Parameter property is set</returns>
        public bool IsSetParameter()
        {
            return (Parameter.Count > 0);
        }

    }
}
