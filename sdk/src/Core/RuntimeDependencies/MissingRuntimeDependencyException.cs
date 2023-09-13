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
using System;
using Amazon.Runtime;

namespace Amazon.RuntimeDependencies
{
    /// <summary>
    /// This exception is thrown when the SDK is used as part of an application compiled for Native AOT with trimming turned on.
    /// In this environment assemblies can not be dynamically loaded which is what the SDK will do by default unless the
    /// runtime dependencies are registered using the Amazon.RuntimeDependencies.GlobalRuntimeDependencyRegistry.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public class MissingRuntimeDependencyException : AmazonClientException
    {

        public MissingRuntimeDependencyException(string packageName, string className, string registerMethod)
            : base("Operation failed because of a missing runtime dependency. In Native AOT builds runtime dependencies can not be " +
                  "dynamically loaded from assembles. Instead the runtime dependency needs to be explicitly registered. " +
                  $"To complete this operation register an instance of {className} from package {packageName} using the " +
                  $"operation {typeof(Amazon.RuntimeDependencies.GlobalRuntimeDependencyRegistry).FullName}.{nameof(GlobalRuntimeDependencyRegistry.Instance)}.{registerMethod}.")
        {
            this.PackageName = packageName;
            this.ClassName = className;
            this.RegisterMethod = registerMethod;
        }

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the MissingRuntimeDependencyException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected MissingRuntimeDependencyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
#endif

        /// <summary>
        /// The package containing the runtime dependency
        /// </summary>
        public string PackageName { get; set; }

        /// <summary>
        /// The class that must be instantiated and registered to Amazon.RuntimeDependencyRegistry
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// The method on Amazon.RuntimeDependencyRegistry that should be called with an instance or factory method for the type referred by the ClassName property.
        /// </summary>
        public string RegisterMethod { get; set; }
    }
}
