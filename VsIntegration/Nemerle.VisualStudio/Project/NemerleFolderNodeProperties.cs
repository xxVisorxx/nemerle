using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Package;
using Microsoft.VisualStudio.Project;

namespace Nemerle.VisualStudio.Project
{
    /// <summary>
    /// Represents folder node properties.
    /// </summary>
    /// <remarks>This class must be public and marked as ComVisible in order for the DispatchWrapper to work correctly.</remarks>
    [CLSCompliant(false)]
    [ComVisible(true)]
    [Guid("C500F21B-92C7-4987-A425-1FB6B42CFBFD")]
    [SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable")]
    public class NemerleFolderNodeProperties : FolderNodeProperties
    {
        // =========================================================================================
        // Constructors
        // =========================================================================================

        /// <summary>
        /// Initializes a new instance of the <see cref="NemerleFolderNodeProperties"/> class.
        /// </summary>
        /// <param name="node">The node that contains the properties to expose via the Property Browser.</param>
        public NemerleFolderNodeProperties(NemerleFolderNode node)
            : base(node)
        {
        }

        // =========================================================================================
        // Methods
        // =========================================================================================

        /// <summary>
        /// Creates a custom property descriptor for the node properties, which affects the behavior
        /// of the property grid.
        /// </summary>
        /// <param name="propertyDescriptor">The <see cref="PropertyDescriptor"/> to wrap.</param>
        /// <returns>A custom <see cref="PropertyDescriptor"/> object.</returns>
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#", Justification = "In the 2005 SDK, it's called p and in the 2008 SDK it's propertyDescriptor")]
        public override DesignPropertyDescriptor CreateDesignPropertyDescriptor(PropertyDescriptor propertyDescriptor)
        {
            return new NemerleDesignPropertyDescriptor(propertyDescriptor);
        }
    }
}
