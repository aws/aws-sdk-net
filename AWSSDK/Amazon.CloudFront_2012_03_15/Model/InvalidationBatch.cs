/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-11-01
 *
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;

namespace Amazon.CloudFront_2012_03_15.Model
{
    /// <summary>
    /// Contains a list of paths to objects that are to be invalidated and a CallerReference to ensure the request can't be replayed.
    /// For more information, please visit:
    /// <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/index.html?InvalidationBatchDatatype.html"/>
    /// </summary>
    public class InvalidationBatch
    {
        private List<string> paths = new List<string>();
        private string callerReference;

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvalidationBatch()
        {
        }

        /// <summary>
        /// Constructs and instance of InvalidationBatch with a callerReference.
        /// </summary>
        /// <param name="callerReference">A unique name that ensures the request can't be replayed.</param>
        public InvalidationBatch(string callerReference)
        {
            this.callerReference = callerReference;
        }

        /// <summary>
        /// Constructs and instance of InvalidationBatch with a callerReference and a list of paths to objects.
        /// </summary>
        /// <param name="callerReference">A unique name that ensures the request can't be replayed.</param>
        /// <param name="paths">A list of paths to objects that will be invalidated.</param>
        public InvalidationBatch(string callerReference, List<string> paths)
        {
            this.callerReference = callerReference;
            this.paths = paths;
        }

        /// <summary>
        /// Gets and Sets the CallerReference property a unique name that ensures the request can't be replayed.
        /// </summary>
        public string CallerReference
        {
            get
            {
                return this.callerReference;
            }
            set
            {
                this.callerReference = value;
            }
        }

        /// <summary>
        /// Sets the CallerReference property and returns back this instance to chain method calls.
        /// </summary>
        /// <param name="callerReference">A unique name that ensures the request can't be replayed.</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InvalidationBatch WithCallerReference(string callerReference)
        {
            this.callerReference = callerReference;
            return this;
        }

        /// <summary>
        /// Gets and Sets the Paths property which is a list of paths to objects that will be invalidated.
        /// </summary>
        public List<string> Paths
        {
            get
            {
                return this.paths;
            }
            set
            {
                this.paths = value;
            }
        }

        /// <summary>
        /// Adds paths to the collection of path strings and returns back this instance to chain method calls.
        /// </summary>
        /// <param name="path">A list of paths to objects that will be invalidated</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InvalidationBatch WithPaths(params string[] path)
        {
            foreach (string p in path)
            {
                this.paths.Add(p);
            }

            return this;
        }

        /// <summary>
        /// Adds paths to the collection of path strings and returns back this instance to chain method calls.
        /// </summary>
        /// <param name="paths">A list of paths to objects that will be invalidated</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InvalidationBatch WithPaths(IEnumerable<string> paths)
        {
            foreach (string p in paths)
            {
                this.paths.Add(p);
            }

            return this;
        }

        /// <summary>
        /// Creates a XML representation of this object and returns it back as a string.
        /// </summary>
        /// <returns>A XML string representing this object.</returns>
        public override string ToString()
        {
            StringWriter sw = new StringWriter();
            XmlTextWriter xmlWriter = new XmlTextWriter(sw);

            xmlWriter.WriteStartElement("InvalidationBatch");

            foreach (string path in Paths)
            {
                string value = path.StartsWith("/") ? path : "/" + path;
                xmlWriter.WriteElementString("Path", value);
            }

            xmlWriter.WriteElementString("CallerReference", this.CallerReference);
            xmlWriter.WriteEndElement();

            xmlWriter.Close();
            return sw.ToString();
        }
    }
}
