// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
namespace Xenko.Core.Reflection
{
    /// <summary>
    /// A category used by <see cref="ITypeDescriptorBase"/>.
    /// </summary>
    public enum DescriptorCategory
    {
        /// <summary>
        /// A primitive.
        /// </summary>
        Primitive,

        /// <summary>
        /// A collection.
        /// </summary>
        Collection,

        /// <summary>
        /// An array
        /// </summary>
        Array,

        /// <summary>
        /// A dictionary
        /// </summary>
        Dictionary,

        /// <summary>
        /// An object
        /// </summary>
        Object,

        /// <summary>
        /// A nullable value
        /// </summary>
        Nullable,

        /// <summary>
        /// A custom descriptor.
        /// </summary>
        Custom
    }
}
